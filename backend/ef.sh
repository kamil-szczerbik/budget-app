#!/bin/bash
dotnet ef "$@" \
  --project BudgetApp.Infrastructure \
  --startup-project BudgetApp.Api
