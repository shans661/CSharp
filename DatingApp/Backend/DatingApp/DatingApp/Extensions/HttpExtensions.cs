﻿using DatingApp.API.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DatingApp.API.Extensions
{
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse httpResponse, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);

            var jsonSerializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            httpResponse.Headers.Add("Pagination", JsonSerializer.Serialize(paginationHeader, jsonSerializerOptions));

            //To expose Pagination header "Access-Control-Expose-Headers" header is mandatory
            httpResponse.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}
