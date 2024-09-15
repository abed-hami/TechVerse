using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Core.Models;
using TechVerse.Services.Interfaces;

namespace TechVerse.Services.Services
{
    public class GiftCardService:IGiftCardService
    {
        private readonly IGiftCardRepository _giftCardRepository;

        public GiftCardService(IGiftCardRepository giftCardRepository)
        {
            _giftCardRepository = giftCardRepository;
        }

        public async Task<IEnumerable<GiftCard>> GetAllGiftCards()
        {
            return await _giftCardRepository.GetAllGiftCards();
        }

        public async Task<GiftCard> GetGiftCardById(int id)
        {
            return await _giftCardRepository.GetGiftCardById(id);
        }

        public async Task AddGiftCard(GiftCard giftCard)
        {
            if (ValidateGiftCard(giftCard))
            {
                await _giftCardRepository.AddGiftCard(giftCard);
            }
            else
            {
                throw new ArgumentException("Invalid giftCard data");
            }
        }

        public async Task UpdateGiftCard(GiftCard giftCard)
        {
            await _giftCardRepository.UpdateGiftCard(giftCard);
        }

        public async Task DeleteGiftCard(int id)
        {
            await _giftCardRepository.DeleteGiftCard(id);
        }

        private bool ValidateGiftCard(GiftCard giftCard)
        {
            if (giftCard.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
