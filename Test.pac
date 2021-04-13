function FindProxyForURL(url, host) {

// DEFAULT RULE: All other traffic, use below proxies, in fail-over order.
// The first proxy is a public proxy from http://www.freeproxylists.net/
// The second proxy is the TSC proxy

	return "PROXY 66.42.52.220:8080; PROXY 10.120.98.6:3128";

}
