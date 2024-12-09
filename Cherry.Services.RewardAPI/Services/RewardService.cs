using Cherry.Services.RewardAPI.Message;
using Cherry.Services.RewardAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Cherry.Services.RewardAPI.Models;

namespace Cherry.Services.RewardAPI.Services
{
    public class RewardService : IRewardService
    {
        private DbContextOptions<AppDbContext> _dbOptions;

        public RewardService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }
        public async Task UpdateRewards(RewardsMessage rewardsMessage)
        {
            try
            {
                Rewards rewards = new()
                {
                    OrderId= rewardsMessage.OrderId,    
                    RewardsActivity= rewardsMessage.RewardsActivity,    
                    UserId=rewardsMessage.UserId,
                    RewardsDate=DateTime.Now,
                };
                await using var _db=new AppDbContext(_dbOptions);
                _db.Rewards.Add(rewards);
                await _db.SaveChangesAsync();   
            }
            catch (Exception ex)
            {
            }
        }
    }
}
