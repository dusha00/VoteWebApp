using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoteWebApp.Models;
using VoteWebApp.Repository;

namespace VoteWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly CommentRepository _commentRepository;

        public CommentController(CommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IEnumerable<CommentModel> RangeQuery(DateTime SearchDate,int PageIndex,int PageSize)
        {
            var list = _commentRepository.RangeQuery(SearchDate, PageIndex,PageSize);
            return list;
        }
    }
}