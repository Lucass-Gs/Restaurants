using MediatR;

namespace Restaurants.Application.Dishes.Commands.DeleteDish;
public class DeleteAllDishesForRestaurantCommand(int restaurantId) : IRequest
{
    public int RestaurantId { get; } = restaurantId;
}
