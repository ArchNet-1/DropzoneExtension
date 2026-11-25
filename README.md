<p align="center">
  <a href="https://archnet-plateform.fr"><img src="https://archnet-plateform.fr/ArchNetLogoWithBck.png" alt="ArchNet" width="240"></a>
</p>

# ArchNet · Dropzone Extension

Fills a container (layout group, list…) with copies of prefabs and removes them when the container is disabled.

- Unity **6000.0** or newer · No dependency.
- Part of [ArchNet](https://archnet-plateform.fr), free and open-source Unity packages

## Install

*Window > Package Manager > + > Install package from git URL…*

```
https://github.com/ArchNet-1/DropzoneExtension.git
```

## Use

```csharp
using ArchNet.Extension;

_dropzone.Fill(itemPrefabs);   // replaces the content
_dropzone.Clear();
```

## License

See [LICENSE.md](LICENSE.md).
