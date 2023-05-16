﻿namespace Ubee.Domain.Configurations;
public class PaginationData
{
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int TotalCount { get; set; }
    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;

    public PaginationData(int totalCount, PaginationParams @params)
    {
        TotalCount = totalCount;
        TotalPages = (int)Math.Ceiling(totalCount / (double)@params.PageSize);
        CurrentPage = @params.PageIndex;
    }

}
