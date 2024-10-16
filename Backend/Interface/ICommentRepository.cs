﻿using Backend.Helpers;
using Backend.Models;

namespace Backend.Interface
{
    public interface ICommentRepository
    {
        Task<List<Comments>> GetAllAsync(CommentQueryObject queryObject);
        Task<Comments?> GetByIdAsync(int id);
        Task<Comments> CreateAsync(Comments commentModel);
        Task<Comments?> DeleteAsync(int id);
        Task<Comments?> UpdateAsync(int id, Comments commentModel); 
    }
}
