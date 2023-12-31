﻿namespace FinancialTracker.Application.Models;

using System.Net;

public class ServiceReponseModel<T>
{
    private readonly List<string> errors;

    public ServiceReponseModel(T data)
       : this(data, HttpStatusCode.OK)
    {
    }

    public ServiceReponseModel(T data, HttpStatusCode statusCode)
        : this(statusCode)
        => this.Data = data;

    public ServiceReponseModel(HttpStatusCode statusCode)
        => this.StatusCode = statusCode;

    public T Data { get; }

    public HttpStatusCode StatusCode { get; private set; }

    public IReadOnlyCollection<string> Errors
       => this.errors;

    public void SetStatusCode(HttpStatusCode statusCode)
        => this.StatusCode = statusCode;

    public void AddErrors(params string[] messages)
        => this.errors.AddRange(messages);
}
