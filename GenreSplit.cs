using System;
using System.Linq;
using System.Threading;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Library;
using Microsoft.Extensions.Logging;

namespace Slugger.GenreSplitter
{
    public class GenreSplit : IMetadataSaver
    {
        private readonly ILogger<GenreSplit> _logger;
        public string Name => "Split genres";

        public GenreSplit(ILogger<GenreSplit> logger)
        {
            _logger = logger;
        }

        public bool IsEnabledFor(BaseItem item, ItemUpdateType updateType)
        {
            var enabled = item
             .Genres
             .Any(genre => genre.Contains(','));

            _logger.LogWarning($"We are checking if we should enable for this one. {enabled}");

            return enabled;
        }

        public void Save(BaseItem item, CancellationToken cancellationToken)
        {
            _logger.LogWarning("Saving item");
            item.AddGenre("Code made this");
        }
    }
}