using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dtos.Character;
using Core.Dtos.Weapon;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IWeaponRepository
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}