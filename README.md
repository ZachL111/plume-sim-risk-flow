# plume-sim-risk-flow

`plume-sim-risk-flow` keeps a focused C# implementation around simulations. The project goal is to create a C# reference implementation for risk workflows, centered on diagnostic reporting, negative fixtures, and human-readable error snapshots.

## Problem It Tries To Make Smaller

The project exists to keep a narrow engineering decision visible and testable. For this repo, that decision is how input pressure and review cost should influence a review result.

## Plume Sim Risk Flow Review Notes

`stress` and `stale` are the cases worth reading first. They show the optimistic and cautious ends of the fixture.

## Working Pieces

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/plume-sim-risk-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `state drift` and `input pressure`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Design Notes

The fixture data drives the tests. The code stays thin, while `metadata/domain-review.json` and `config/review-profile.json` explain what each case is meant to protect.

The added C# path is deliberately direct, with fixtures doing most of the explaining.

## Example Run

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Tests

The check exercises the source code and the review fixture. `stress` is the high score at 184; `stale` is the low score at 139.

## Known Limits

This remains a local project with deterministic fixtures. It does not depend on credentials, hosted services, or live data. Future work should add richer malformed inputs before widening the public API.
