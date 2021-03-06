﻿/*
Copyright (C) 2016 Anki Universal Team <ankiuniversal@outlook.com>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as
published by the Free Software Foundation, either version 3 of the
License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Net;

namespace AnkiU.AnkiCore.Sync
{
    public interface ISyncer
    {
        Task<HttpResponseMessage> Meta();
        Task<JsonObject> Start(JsonObject kw);
        Task<JsonObject> ApplyChanges(JsonObject kw);
        Task<JsonObject> Chunk(JsonObject kw = null);
        Task ApplyChunk(JsonObject sech);
        Task<JsonObject> SanityCheck2(JsonObject client);
        Task<long> Finish();
    }
}
