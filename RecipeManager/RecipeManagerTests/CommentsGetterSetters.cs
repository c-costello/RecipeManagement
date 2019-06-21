using System;
using Xunit;
using RecipeManager.Models;
using System.Collections.Generic;

namespace RecipeManagerTests
{
    public class CommentsGetterSetters
    {
        [Fact]
        public void CanGetID()
        {
            Comment comment = new Comment()
            {
                ID = 1,
            };
            Assert.Equal(1, comment.ID);
        }
        [Fact]
        public void CanGetRecipeID()
        {
            Comment comment = new Comment()
            {
                RecipeID = 1,
            };
            Assert.Equal(1, comment.RecipeID);
        
        }
        [Fact]
        public void CanGetAuthor()
        {
            Comment comment = new Comment()
            {
                Author = "author",
            };
            Assert.Equal("author", comment.Author);
        }
        [Fact]
        public void CanGetDetails()
        {
            Comment comment = new Comment()
            {
                Details = "details"
            };
            Assert.Equal("details", comment.Details);
        }
        [Fact]
        public void CanGetDate()
        {
            DateTime date = new DateTime(1999, 12, 12);
            Comment comment = new Comment()
            {
                Date = date,
            };
            Assert.Equal(date, comment.Date);
        }

        [Fact]
        public void CanSetID()
        {
            Comment comment = new Comment()
            {
                ID = 1,
            };
            comment.ID = 2;
            Assert.Equal(2, comment.ID);
        }
        [Fact]
        public void CanSetRecipeID()
        {
            Comment comment = new Comment()
            {
                RecipeID = 1,
            };
            comment.RecipeID = 2;
            Assert.Equal(2, comment.RecipeID);

        }
        [Fact]
        public void CanSetAuthor()
        {
            Comment comment = new Comment()
            {
                Author = "author",
            };
            comment.Author = "new author";
            Assert.Equal("new author", comment.Author);
        }
        [Fact]
        public void CanSetDetails()
        {
            Comment comment = new Comment()
            {
                Details = "details"
            };
            comment.Details = "new detail";
            Assert.Equal("new details", comment.Details);
        }
        [Fact]
        public void CanSetDate()
        {
            DateTime date = new DateTime(1999, 12, 12);
            DateTime newDate = new DateTime(2012, 12, 12);
            Comment comment = new Comment()
            {
                Date = date,
            };
            comment.Date = newDate;
            Assert.Equal(newDate, comment.Date);
        }

    }
}
