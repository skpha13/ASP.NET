using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Repositories.GenericRepository;

namespace Lab4_23.Repositories.ReviewRepository;

public class ReviewRepository: GenericRepository<Review>, IReviewRepository
{
    public ReviewRepository(Lab4Context lab4Context): base(lab4Context) {}
}