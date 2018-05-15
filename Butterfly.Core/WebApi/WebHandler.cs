﻿/*
 * Copyright 2017 Fireshark Studios, LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Butterfly.Core.WebApi {
    /// <summary>
    /// Internal class used to store references to new web handlers
    /// </summary>
    public class WebHandler {
        public HttpMethod method;
        public string path;
        public Func<IHttpRequest, IHttpResponse, Task> listener;
    }
}
