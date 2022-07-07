using System;

namespace Demo.Catalog
{
    public sealed class DependencyProvider
    {
        private static readonly Lazy<DependencyProvider> _lazyDependencyProvider = new Lazy<DependencyProvider>(() => new DependencyProvider());

        private DependencyProvider() { }

        public static DependencyProvider Instance
        {
            get
            {
                return _lazyDependencyProvider.Value;
            }
        }

        public void SetServiceProvider(IServiceProvider serviceProvider) => ServiceProvider = serviceProvider;

        public IServiceProvider ServiceProvider { get; private set; }
    }
}
