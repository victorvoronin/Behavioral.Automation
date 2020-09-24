using Behavioral.Automation.Services.Mapping.Contract;
using JetBrains.Annotations;

namespace Behavioral.Automation.Services.Mapping
{
    public sealed class VirtualizedControlScopeContext : IVirtualizedScopeContext
    {
        private readonly ControlScopeContext _controlScopeContext;

        public VirtualizedControlScopeContext(ControlScopeId contextId,
            [CanBeNull] IMarkupStorage markupStorage)
        {
            _controlScopeContext = new ControlScopeContext(contextId, markupStorage);
        }

        public ControlDescription FindControlDescription(string type, string name)
        {
            return _controlScopeContext.FindControlDescription(type, name);
        }

        public IControlScopeContext GetNestedControlScopeContext(ControlScopeId controlScopeId)
        {
            return _controlScopeContext.GetNestedControlScopeContext(controlScopeId);
        }
    }
}
