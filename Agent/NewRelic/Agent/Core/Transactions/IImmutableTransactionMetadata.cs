using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using NewRelic.Agent.Core.Errors;

namespace NewRelic.Agent.Core.Transactions
{
	public interface IImmutableTransactionMetadata : ITransactionAttributeMetadata
	{
		IEnumerable<string> CrossApplicationAlternatePathHashes { get; }
		string CrossApplicationReferrerTransactionGuid { get; }
		string CrossApplicationReferrerPathHash { get; }
		string CrossApplicationPathHash { get; }
		string CrossApplicationReferrerProcessId { get; }
		string CrossApplicationReferrerTripId { get; }
		float CrossApplicationResponseTimeInSeconds { get; }

		bool HasOutgoingDistributedTracePayload { get; }
		int? HttpResponseSubStatusCode { get; }
		string SyntheticsResourceId { get; }
		string SyntheticsJobId { get; }
		string SyntheticsMonitorId { get; }
		bool IsSynthetics { get; }
		bool HasCatResponseHeaders { get; }
	}
}