using System;

namespace Interfaces
{
    public interface IPhotoProvider
    {
        void TakePhoto(Action<byte[]> callback);
    }
}
