using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResourceMgr.API
{
    public class TimeRange : IValidatableObject
    {
        public DateTime? From { get; set; }
        public DateTime? Until { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (validationContext == null)
                yield break;

            var instance = validationContext.ObjectInstance as TimeRange;
            if (instance == null)
                yield break;

            // if both are null
            if ((instance.From == null) && (instance.Until == null))
                yield return new ValidationResult($"Both '{nameof(From)}' and '{nameof(Until)}' are null. At least one of them should be specified.", new string[] { nameof(From), nameof(Until) });
        }
    }
}
