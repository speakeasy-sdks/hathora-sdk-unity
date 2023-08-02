.PHONY: *

local:
	go run ../openapi-generation/cmd/generate/main.go -o . -s hathora.json -l unity
