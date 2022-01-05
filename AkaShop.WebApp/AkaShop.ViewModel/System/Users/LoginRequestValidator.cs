using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.ViewModel.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tên người dùng là bắt buộc");
            RuleFor(x => x.Password).NotEmpty().WithMessage("mật khẩu là bắt buộc")
                .MinimumLength(6).WithMessage("Mật khẩu phải có ít nhất 6 ký tự");
        }
    }
}
