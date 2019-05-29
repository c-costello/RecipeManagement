using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface IComment
    {
        Task<IEnumerable<Comment>> GetComments(int recipeID);
        Task<Comment> GetComment(int id);
        Task<Comment> CreateComment(Comment comment);
        Task<Comment> UpdateComment(Comment comment);
        Task DeleteCommentByID(int id);
    }
}
