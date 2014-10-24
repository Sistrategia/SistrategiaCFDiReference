/**************************************************************************
 * Sistrategia.SAT.CFDI.SATManager.cs 
 * 
 * Author(s):   José Ernesto Ocampo Cicero <ernesto@sistrategia.com>
 * Last Update:	2014-Oct-10
 * Created:	    2010-Dec-16
 * 
 * (C) 2010-2014 José Ernesto Ocampo Cicero
 * Copyright (C) José Ernesto Ocampo Cicero, 2010-2014
 * All rights reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License. 
 *************************************************************************/

using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Sistrategia.SAT.CFDI;

namespace Sistrategia.SAT
{
    public class SATManager
    {
        public static Comprobante CreateComprobante() {
            return new Comprobante();
        }


        #region Util Functions

        internal static string NormalizeWhiteSpace(string S) {
            if (string.IsNullOrEmpty(S))
                return S;

            string s = S.Trim();
            bool iswhite = false;
            // int iwhite;
            int sLength = s.Length;
            System.Text.StringBuilder sb = new System.Text.StringBuilder(sLength);
            foreach (char c in s.ToCharArray()) {
                if (Char.IsWhiteSpace(c)) {
                    if (iswhite) {
                        //Continuing whitespace ignore it.
                        continue;
                    }
                    else {
                        //New WhiteSpace

                        //Replace whitespace with a single space.
                        sb.Append(" ");
                        //Set iswhite to True and any following whitespace will be ignored
                        iswhite = true;
                    }
                }
                else {
                    sb.Append(c.ToString());
                    //reset iswhitespace to false
                    iswhite = false;
                }
            }
            return sb.ToString();
        }

        #endregion
    }
}
