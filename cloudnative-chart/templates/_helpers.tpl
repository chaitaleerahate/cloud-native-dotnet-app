
{{- define "cloudnative.fullname" -}}
{{ .Release.Name }}-{{ .Chart.Name }}
{{- end }}

