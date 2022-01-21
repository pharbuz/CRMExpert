﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HRBN.Thesis.CRMExpert.Domain;
using HRBN.Thesis.CRMExpert.Domain.Core.Entities;
using HRBN.Thesis.CRMExpert.Domain.Core.Enums;
using HRBN.Thesis.CRMExpert.Domain.Core.Pagination;
using HRBN.Thesis.CRMExpert.Domain.Core.Repositories;
using HRBN.Thesis.CRMExpert.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;

namespace HRBN.Thesis.CRMExpert.Infrastructure.Repositories
{
    public sealed class ContactsRepository : IContactsRepository
    {
        private readonly CRMContext _dbContext;

        public ContactsRepository(CRMContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Contact contact)
        {
            await _dbContext.Contacts.AddAsync(contact);
        }

        public async Task DeleteAsync(Contact contact)
        {
            await Task.Factory.StartNew(() =>
            {
                _dbContext.Contacts.Remove(contact);
            });
        }

        public async Task<Contact> GetAsync(Guid id)
        {
            var contact = await _dbContext.Contacts.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return contact;
        }

        public async Task<IPageResult<Contact>> SearchAsync(string searchPhrase, int pageNumber, int pageSize, string orderBy,
            SortDirection sortDirection)
        {
            var baseQuery = _dbContext.Contacts
                .Where(c => (searchPhrase == null ||
                             c.Id.ToString().Contains(searchPhrase)
                             || c.FirstName.ToLower().Contains(searchPhrase.ToLower())
                             || c.LastName.ToLower().Contains(searchPhrase.ToLower())
                             || c.Phone.ToLower().Contains(searchPhrase.ToLower())
                             || c.Email.ToLower().Contains(searchPhrase.ToLower())
                             || c.Street.ToLower().Contains(searchPhrase.ToLower())
                             || c.PostalCode.ToLower().Contains(searchPhrase.ToLower())
                             || c.City.ToLower().Contains(searchPhrase.ToLower())
                             || c.ContactComment.ToLower().Contains(searchPhrase.ToLower())
                    ));
            if (!string.IsNullOrEmpty(orderBy))
            {
                var columnSelectors = new Dictionary<string, Expression<Func<Contact, object>>>()
                {
                    {nameof(Contact.FirstName), c => c.FirstName},
                    {nameof(Contact.LastName), c => c.LastName},
                    {nameof(Contact.Phone), c => c.Phone},
                    {nameof(Contact.Email), c => c.Email},
                    {nameof(Contact.Street), c => c.Street},
                    {nameof(Contact.PostalCode), c => c.PostalCode},
                    {nameof(Contact.City), c => c.City},
                    {nameof(Contact.ContactComment), c => c.ContactComment}
                };

                Expression<Func<Contact, object>> selectedColumn;

                if (columnSelectors.Keys.Contains(orderBy))
                {
                    selectedColumn = columnSelectors[orderBy];
                }
                else
                {
                    selectedColumn = columnSelectors["FirstName"];
                }

                baseQuery = sortDirection == SortDirection.ASC
                    ? baseQuery.OrderBy(selectedColumn)
                    : baseQuery.OrderByDescending(selectedColumn);
            }

            var contacts = await baseQuery.Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            return new PageResult<Contact>(contacts, baseQuery.Count(), pageSize, pageNumber);
        }

        public async Task<IPageResult<Contact>> SearchAsync(Guid userId, string searchPhrase, int pageNumber,
            int pageSize, string orderBy, SortDirection sortDirection)
        {
            var baseQuery = _dbContext.Contacts
                .Where(c => (searchPhrase == null ||
                             (c.Id.ToString().Contains(searchPhrase)
                              || c.FirstName.ToLower().Contains(searchPhrase.ToLower())
                              || c.LastName.ToLower().Contains(searchPhrase.ToLower())
                              || c.Phone.ToLower().Contains(searchPhrase.ToLower())
                              || c.Email.ToLower().Contains(searchPhrase.ToLower())
                              || c.Street.ToLower().Contains(searchPhrase.ToLower())
                              || c.PostalCode.ToLower().Contains(searchPhrase.ToLower())
                              || c.City.ToLower().Contains(searchPhrase.ToLower())
                              || c.ContactComment.ToLower().Contains(searchPhrase.ToLower())
                             )) && c.UserId == userId);
            if (!string.IsNullOrEmpty(orderBy))
            {
                var columnSelectors = new Dictionary<string, Expression<Func<Contact, object>>>()
                {
                    {nameof(Contact.FirstName), c => c.FirstName},
                    {nameof(Contact.LastName), c => c.LastName},
                    {nameof(Contact.Phone), c => c.Phone},
                    {nameof(Contact.Email), c => c.Email},
                    {nameof(Contact.Street), c => c.Street},
                    {nameof(Contact.PostalCode), c => c.PostalCode},
                    {nameof(Contact.City), c => c.City},
                    {nameof(Contact.ContactComment), c => c.ContactComment}
                };

                Expression<Func<Contact, object>> selectedColumn;

                if (columnSelectors.Keys.Contains(orderBy))
                {
                    selectedColumn = columnSelectors[orderBy];
                }
                else
                {
                    selectedColumn = columnSelectors["FirstName"];
                }

                baseQuery = sortDirection == SortDirection.ASC
                    ? baseQuery.OrderBy(selectedColumn)
                    : baseQuery.OrderByDescending(selectedColumn);
            }

            var contacts = await baseQuery.Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            return new PageResult<Contact>(contacts, baseQuery.Count(), pageSize, pageNumber);
        }

        public async Task UpdateAsync(Contact contact)
        {
            await Task.Factory.StartNew(() =>
            {
                _dbContext.Contacts.Update(contact);
            });
        }
    }
}