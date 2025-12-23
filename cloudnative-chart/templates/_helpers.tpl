{{- define "cloudnative.fullname" -}}
{{- if .Release.Name }}
{{ .Release.Name }}
{{- else }}
{{ .Chart.Name }}
{{- end }}
{{- end -}}
