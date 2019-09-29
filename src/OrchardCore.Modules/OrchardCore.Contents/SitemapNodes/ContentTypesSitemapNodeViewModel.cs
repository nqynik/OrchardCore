using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.Sitemaps.Models;

namespace OrchardCore.Contents.SitemapNodes
{
    public class ContentTypesSitemapNodeViewModel
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public string Path { get; set; }

        public ContentTypeSitemapEntryViewModel[] ContentTypes { get; set; } = new ContentTypeSitemapEntryViewModel[] { };

        [BindNever]
        public SitemapNode SitemapNode { get; set; }

        [BindNever]
        public bool CanBeChildNode { get; set; }

        [BindNever]
        public bool CanSupportChildNodes { get; set; }
    }

    public class ContentTypeSitemapEntryViewModel
    {
        public bool IsChecked { get; set; }
        public string ContentTypeName { get; set; }
        public ChangeFrequency ChangeFrequency { get; set; }
        public float Priority { get; set; }
        public bool TakeAll { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}