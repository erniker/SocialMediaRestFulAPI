using SocialMedia.Core.QueryFilters;
using System;

namespace SocialMedia.Infrastructure.Interface
{
    public interface IUriService
    {
        Uri GetPostPaginationUri(PostQueryFilter filter, string actionUrl);
    }
}