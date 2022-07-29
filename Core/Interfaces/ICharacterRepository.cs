using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ICharacterRepository
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}