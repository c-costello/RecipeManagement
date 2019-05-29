using Microsoft.EntityFrameworkCore;
using RecipeManager.Data;
using RecipeManager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Services
{
    public class CommentService : IComment
    {
        private readonly RecipeDbContext _context;

        public CommentService(RecipeDbContext context)
        {
            _context = context;
        }
        public async Task<Comment> CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task DeleteCommentByID(int id)
        {
            Comment comment = await GetComment(id);
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

        }

        public async Task<Comment> GetComment(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

        public async Task<IEnumerable<Comment>> GetComments(int recipeID)
        {
            IEnumerable<Comment> comments = await _context.Comments.ToListAsync();
            return comments.Where(r => r.RecipeID == recipeID);
        }

        public async Task<Comment> UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
    }
}
