﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Application.Features.Products.Command.Delete
{
    public class DeleteProductCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}