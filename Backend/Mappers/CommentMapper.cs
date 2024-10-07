using Backend.DTO_s;
using Backend.Models;
using System.Runtime.CompilerServices;

namespace Backend.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comments commentModel )
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                CreatedBy=commentModel.AppUser.UserName,
                StockId = commentModel.StockId
            };

        }
        public static Comments ToCommentFromCreate(this CreateCommentDto commentDto,int stockId)
        {
            return new Comments
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
             
                StockId = stockId
            };

        }
        public static Comments ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
            return new Comments
            {
                Title = commentDto.Title,
                Content = commentDto.Content,

                
            };

        }
    }
}
