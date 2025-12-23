{{/*
Return the fully qualified app name
Works in Helm CLI, Helm lint, and Argo CD
*/}}
{{- define "cloudnative.fullname" -}}
{{- if .Release }}
{{- if .Release.Name }}
{{ .Release.Name }}
{{- else }}
{{ .Chart.Name }}
{{- end }}
{{- else }}
{{ .Chart.Name }}
{{- end }}
{{- end }}
