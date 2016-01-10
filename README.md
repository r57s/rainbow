:rainbow: rainbow
=======

- Web Colours for Unity Color and Color32 structs
- Only single file less than 350 lines of code.
- No external assets required.
- Easy to integrate.
- rainbow is MIT licensed.

### Example Usage

Copy `Rainbow.cs` into your project.

```c#
camera.backgroundColor = WebColor.hotPink;
```

### Other API
- `WebColor32` has the same colours but in the Color32 form.
- `WebColor` and `WebColor32` classes have a `HexCode` static function in the form of: `WebColor.HexCode(0xFF00FF);` or `WebColor32.HexCode(0xFF00FF);`.

## Releases
- v1.0.0 (10/01/2016)
  - Initial Release