﻿using System;
using System.Collections.Specialized;
using System.IO;

namespace AspNetCoreMini
{
    public class HttpRequest
    {
        private IHttpRequestFeature _feature;
        public Uri Url => _feature.Url;
        public NameValueCollection Headers => _feature.Headers;
        public Stream Body => _feature.Body;
        public HttpRequest(IFeatureCollections features) => _feature = features.Get<IHttpRequestFeature>();
    }
}
