using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Mappers;
using Backend.DTO_s;
using Microsoft.EntityFrameworkCore;
using Backend.Interface;
using Backend.Helpers;

namespace Backend.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
        
    {
        private readonly IStockRepository _stockRepo;
        private readonly ApplicationDBContext _dbContext;
        public StockController(ApplicationDBContext context, IStockRepository stockRepo)
        {
            _dbContext = context;
            _stockRepo=stockRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stocks = await _stockRepo.GetAllAsync(query);
            var stockDto = stocks.Select(s => s.ToStockDTO()).ToList();
            return Ok(stockDto);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stock = await _stockRepo.GetByIdAsync(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock.ToStockDTO());
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStockRequestDTO stockDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stockModel = stockDto.ToStockFromCreateDTO();
            await _stockRepo.CreateAsync(stockModel);
            return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel.ToStockDTO());
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStockRequestDTO updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stockModel=await _stockRepo.UpdateAsync(id, updateDto);
            if(stockModel == null)
            {
                return NotFound();
            }
           

            
            return Ok(stockModel.ToStockDTO());
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stockModel=await _stockRepo.DeleteAsync(id);
            if (stockModel == null)
            {
                return NotFound();
            }
            
            return NoContent();
        }
    }
}
