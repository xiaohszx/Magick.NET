﻿// Copyright 2013-2019 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using System.Globalization;

namespace ImageMagick
{
    internal sealed class ExifSignedByte : ExifValue<sbyte>
    {
        public ExifSignedByte(ExifTagValue tag)
            : base(tag)
        {
        }

        public override ExifDataType DataType => ExifDataType.SignedByte;

        protected override string StringValue => Value.ToString("X2", CultureInfo.InvariantCulture);

        public override bool SetValue(object value)
        {
            if (base.SetValue(value))
                return true;

            switch (value)
            {
                case int intValue:
                    Value = (sbyte)intValue;
                    return true;
                default:
                    return false;
            }
        }
    }
}
