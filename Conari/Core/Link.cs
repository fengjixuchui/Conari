﻿/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2016-2018  Denis Kuzmin < entry.reg@gmail.com > :: github.com/3F
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Conari"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
*/

using System;

namespace net.r_eg.Conari.Core
{
    public struct Link
    {
        /// <summary>
        /// The name of used library.
        /// </summary>
        public string LibName
        {
            get;
            private set;
        }

        /// <summary>
        /// A handle of loaded library.
        /// </summary>
        internal IntPtr Handle
        {
            get;
            private set;
        }

        public bool IsActive
        {
            get {
                return Handle != IntPtr.Zero;
            }
        }

        public Link(IntPtr handle, string library)
        {
            Handle  = handle;
            LibName = library;
        }

        public Link(string library)
            : this(IntPtr.Zero, library)
        {

        }
    }
}
