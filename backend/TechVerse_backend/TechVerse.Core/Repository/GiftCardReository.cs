using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Core.Models;

namespace TechVerse.Core.Repository
{
    public class GiftCardRepository:IGiftCardRepository
    {
        private readonly TechVerseContext _dbContext;

        public GiftCardRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GiftCard>> GetAllGiftCards()
        {
            return await _dbContext.Set<GiftCard>().ToListAsync();
        }

        public async Task<GiftCard> GetGiftCardById(int id)
        {
            return await _dbContext.Set<GiftCard>().FindAsync(id);
        }

        public async Task AddGiftCard(GiftCard card)
        {
            await _dbContext.Set<GiftCard>().AddAsync(card);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateGiftCard(GiftCard card)
        {
            var existingEntity = _dbContext.Set<GiftCard>().Local.FirstOrDefault(e => e.Id == card.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(card).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteGiftCard(int id)
        {
            var card = await _dbContext.Set<GiftCard>().FindAsync(id);
            if (card != null)
            {
                _dbContext.Set<GiftCard>().Remove(card);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
