using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using Microsoft.Extensions.Logging;
using Slugger.GenreSplitter.Configuration;

namespace Slugger.GenreSplitter
{
    public class Plugin : BasePlugin<PluginConfiguration>
    {
        private readonly ILogger<Plugin> _logger;
        public override string Name => "Genre Splitter";
        public override Guid Id => Guid.Parse("506ca721-62d8-42b5-8d42-152e11336da1");

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer, ILogger<Plugin> logger) : base(applicationPaths, xmlSerializer)
        {
            _logger = logger;

            //_logger.LogWarning("We hit our warning in our plugin");
        }
    }
}