# Review Journal

The review surface for `plume-sim-risk-flow` is deliberately narrow: one fixture, one scoring rule, and one local check.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 144, lane `ship`
- `stress`: `state drift`, score 184, lane `ship`
- `edge`: `review cost`, score 179, lane `ship`
- `recovery`: `decision risk`, score 147, lane `ship`
- `stale`: `input pressure`, score 139, lane `watch`

## Note

This file is intentionally plain so the fixture remains the source of truth.
