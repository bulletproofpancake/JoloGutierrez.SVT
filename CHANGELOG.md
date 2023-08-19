# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.0.4] - 2023-08-19

### Added

- `BypassVariableReference` class
- Documentation for Variable and Bypass Variable References
- `.gitignore` to ignore the hidden folders of Unity

### Changed

- Versioning number to further comply with semver
- Menu path on `CreateAssetMenu` attribute of some scriptable objects

### Removed

- Variable References for common built-in types

## [0.0.3] - 2023-07-16

### Added

- Variable References for common built-in types

- `Create Directory` button for `FilePathReference ` [#3](https://github.com/bulletproofpancake/SVT.Unity/pull/3)

### Fixed

- Missing `/` for the Resources path [#1](https://github.com/bulletproofpancake/SVT.Unity/issues/1)

### Changed

- Properties regarding the `FilePathReference` [#3](https://github.com/bulletproofpancake/SVT.Unity/pull/3)

## [0.0.2] - 2023-07-15

### Added

- FilePathReference ScriptableObject which can be used to easily access folders within Unity
- MIT License

### Fixed

- Missing meta files for CHANGELOG and LICENSE

### Changed

- Namespaces for Runtime scripts

## [0.0.1] - 2023-07-15

### Added

- Project directory creation based on [Jason Storey's Tutorial](https://youtu.be/nVieP57TD20)
- Initial ScriptableObject event system based on [Ryan Hipple's Unite presentation](https://youtu.be/raQ3iHhE_Kk)
    