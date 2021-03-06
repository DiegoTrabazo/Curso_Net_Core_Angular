﻿using Northwind.BusinessLogic.Interfaces;
using Northwind.Models;
using Northwind.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.BusinessLogic.Implementatios
{
    public class TokenLogic : ITokenLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public TokenLogic(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public User ValidateUser(string email, string password) => _unitOfWork.User.ValidateUser(email, password);
    }
}
