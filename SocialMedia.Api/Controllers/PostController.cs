using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _postRepository.GetPosts();
            var postDto = posts.Select(x => new PostDto
            {
                 UserId = x.PostId,
                 PostId = x.PostId,
                 Description = x.Description,
                 Image = x.Image,
                 Date = x.Date
            });
            return Ok(postDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var post = await _postRepository.GetPost(id);
            var postDto = new PostDto
            {
                UserId = post.PostId,
                PostId = post.PostId,
                Description = post.Description,
                Image = post.Image,
                Date = post.Date
            };
            return Ok(postDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostDto postDto)
        {
            var post = new Post
            {
                UserId = postDto.PostId,
                Description = postDto.Description,
                Image = postDto.Image,
                Date = postDto.Date
            };
            await _postRepository.InsertPost(post);
            return Ok(post);
        }

    }
}
