﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.ViewModel.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Tên là bắt buộc").MaximumLength(200).WithMessage("Tên không được quá 200 ký tự");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Họ là bắt buộc").MaximumLength(200).WithMessage("Họ không được quá 200 ký tự");
            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Ngày sinh không được lớn hơn 100");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email là bắt buộc").Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Định dạng email không khớp");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Số điện thoại là bắt buộc");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tên người dùng là bắt buộc");
            RuleFor(x => x.Password).NotEmpty().WithMessage("mật khẩu là bắt buộc")
                .MinimumLength(6).WithMessage("Mật khẩu phải có ít nhất 6 ký tự");
            RuleFor(x => x).Custom((request, context) => {
                if (request.Password != request.ConfirnPassword)
                {
                    context.AddFailure("Nhập lại mật khẩu không đúng");
                }
            });
        }
    }
}
