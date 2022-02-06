﻿using AutoMapper;
using WebPageAnalyzer.Analyzer.Models;
using WebPageAnalyzer.Storage.Dto;

namespace WebPageAnalyzer.Extensions;

internal static class AutoMapperExtensions
{
    public static IMapperConfigurationExpression Setup(this IMapperConfigurationExpression expression)
    {
        expression.CreateMap<TaskInputModel, TaskDto>();
        expression.CreateMap<TaskDto, TaskOutputModel>();
        expression.CreateMap<WordsCountResult, ResultDto>();
        return expression;
    } 
}