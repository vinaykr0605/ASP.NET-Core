using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class SalesHub : Hub
{
    public async Task PostNewSale(int amount)
    {
        if (amount > 10000)
        {
            await Clients.All.SendAsync("ReceivedLargeSale", amount);
        }
    }
}
