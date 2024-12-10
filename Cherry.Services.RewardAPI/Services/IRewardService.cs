using Cherry.Services.RewardAPI.Message;

namespace Cherry.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
