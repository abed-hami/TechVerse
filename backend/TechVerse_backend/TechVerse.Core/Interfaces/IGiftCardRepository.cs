using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Models;

namespace TechVerse.Core.Interfaces
{
    public interface IGiftCardRepository
    {
        Task<IEnumerable<GiftCard>> GetAllGiftCards();
        Task<GiftCard> GetGiftCardById(int id);
        Task AddGiftCard(GiftCard card);
        Task UpdateGiftCard(GiftCard card);
        Task DeleteGiftCard(int id);
    }
}
