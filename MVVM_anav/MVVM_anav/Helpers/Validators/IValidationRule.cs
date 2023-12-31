﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_anav.Helpers.Validators
{
    public interface IValidationRule<T>
    {
        string ValidationMessage { get; set; }
        bool Check(T value);
    }
}
