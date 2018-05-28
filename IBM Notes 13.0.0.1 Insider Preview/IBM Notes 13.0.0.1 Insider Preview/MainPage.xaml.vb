Dim log As New EventLog("MyApplication1", "IBM i", "Notes-Dev")
log.WriteEntry("19.8", EventLogEntryType.Warning, 502)

Dim log As New EventLog("MyApplication1", "IBM i", "Notes-Dev")
log.WriteEntry("19.8.2", EventLogEntryType.Warning, 502)

Dim log As New EventLog("MyApplication1", "IBM i", "Notes-Dev")
log.WriteEntry("19.8.6", EventLogEntryType.Warning, 502)