{{/*
Return the fully qualified app name
Safe for helm lint, template, and Argo CD
*/}}
{{- define "cloudnative.fullname" -}}
{{- if .Release }}
  {{- if .Release.Name }}
    {{ .Release.Name }}
  {{- else if .Chart }}
    {{ .Chart.Name | default "chart-name" }}
  {{- else }}
    chart-name
  {{- end }}
{{- else if .Chart }}
  {{ .Chart.Name | default "chart-name" }}
{{- else }}
  chart-name
{{- end }}
{{- end }}
