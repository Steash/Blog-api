using System;
using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
	public interface IBlogPostRepository
	{
		Task<BlogPost?> GetByIdAsync(Guid id);

		Task<IEnumerable<BlogPost>> GetAllAsync();

		Task<BlogPost> CreateAsync(BlogPost blogPost);

		Task<BlogPost?> UpdateAsync(BlogPost blogPost);

		Task<BlogPost?> DeleteAsync(Guid id);
	}
}