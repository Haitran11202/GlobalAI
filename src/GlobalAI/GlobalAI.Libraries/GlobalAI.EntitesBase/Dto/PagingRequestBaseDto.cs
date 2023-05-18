﻿//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GlobalAI.EntitiesBase.Dto
{
    public class PagingRequestBaseDto
    {
        [FromQuery(Name = "pageSize")]
        public int PageSize { get; set; }

        [FromQuery(Name = "pageNumber")]
        public int PageNumber { get; set; }

        private string _keyword { get; set; } = String.Empty;
        [FromQuery(Name = "keyword")]
        public string Keyword
        {
            get => _keyword;
            set => _keyword = value?.Trim();
        } 

        [NotMapped]
        public int Skip
        {
            get
            {
                int skip = (PageNumber - 1) * PageSize;
                if (skip < 0)
                {
                    skip = 0;
                }
                return skip;
            }
        }
    }
}
