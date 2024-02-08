using System;
using Cysharp.Threading.Tasks;
using FairyGUI;
using MK;

namespace MK.Client
{
    public static class FUIHelper
    {
        #region AddListnerAsync(this GObject self, Func<UniTask> action)

        public static void AddListnerAsync(this GObject self, Func<UniTask> action)
        {
            async UniTask ClickActionAsync()
            {
                FUICollectionService.Instance.isClicked = true;
                await action();
                FUICollectionService.Instance.isClicked = false;
            }

            self.onClick.Set(() =>
            {
                if (FUICollectionService.Instance.isClicked)
                {
                    return;
                }

                UniTask.Void(async () => { await ClickActionAsync(); });
            });
        }

        public static void AddListnerAsync<P1>(this GObject self, Func<P1, UniTask> action, P1 p1)
        {
            async UniTask ClickActionAsync()
            {
                FUICollectionService.Instance.isClicked = true;
                await action(p1);
                FUICollectionService.Instance.isClicked = false;
            }

            self.onClick.Set(() =>
            {
                if (FUICollectionService.Instance.isClicked)
                {
                    return;
                }

                UniTask.Void(async () => { await ClickActionAsync(); });
            });
        }

        public static void AddListnerAsync<P1, P2>(this GObject self, Func<P1, P2, UniTask> action, P1 p1, P2 p2)
        {
            async UniTask ClickActionAsync()
            {
                FUICollectionService.Instance.isClicked = true;
                await action(p1, p2);
                FUICollectionService.Instance.isClicked = false;
            }

            self.onClick.Set(() =>
            {
                if (FUICollectionService.Instance.isClicked)
                {
                    return;
                }

                UniTask.Void(async () => { await ClickActionAsync(); });
            });
        }

        public static void AddListnerAsync<P1, P2, P3>(this GObject self, Func<P1, P2, P3, UniTask> action, P1 p1,
            P2 p2, P3 p3)
        {
            async UniTask ClickActionAsync()
            {
                FUICollectionService.Instance.isClicked = true;
                await action(p1, p2, p3);
                FUICollectionService.Instance.isClicked = false;
            }

            self.onClick.Set(() =>
            {
                if (FUICollectionService.Instance.isClicked)
                {
                    return;
                }

                UniTask.Void(async () => { await ClickActionAsync(); });
            });
        }

        #endregion

        #region AddListner(this GObject self, Action action)

        public static void AddListner(this GObject self, Action action)
        {
            self.onClick.Set(() => { action?.Invoke(); });
        }

        public static void AddListner<P1>(this GObject self, Action<P1> action, P1 p1)
        {
            self.onClick.Set(() => { action?.Invoke(p1); });
        }

        public static void AddListner<P1, P2>(this GObject self, Action<P1, P2> action, P1 p1, P2 p2)
        {
            self.onClick.Set(() => { action?.Invoke(p1, p2); });
        }

        public static void AddListner<P1, P2, P3>(this GObject self, Action<P1, P2, P3> action, P1 p1, P2 p2, P3 p3)
        {
            self.onClick.Set(() => { action?.Invoke(p1, p2, p3); });
        }

        #endregion

        #region AddListnerAsync(this GObject self, Func<EventContext, UniTask> action)

        public static void AddListnerAsync(this GObject self, Func<EventContext, UniTask> action)
        {
            async UniTask ClickActionAsync(EventContext context)
            {
                FUICollectionService.Instance.isClicked = true;
                await action(context);
                FUICollectionService.Instance.isClicked = false;
            }

            self.onClick.Set((context) =>
            {
                if (FUICollectionService.Instance.isClicked)
                {
                    return;
                }

                UniTask.Void(async () => { await ClickActionAsync(context); });
            });
        }

        public static void AddListnerAsync<P1>(this GObject self, Func<EventContext, P1, UniTask> action, P1 p1)
        {
            async UniTask ClickActionAsync(EventContext context)
            {
                FUICollectionService.Instance.isClicked = true;
                await action(context, p1);
                FUICollectionService.Instance.isClicked = false;
            }

            self.onClick.Set((context) =>
            {
                if (FUICollectionService.Instance.isClicked)
                {
                    return;
                }

                UniTask.Void(async () => { await ClickActionAsync(context); });
            });
        }

        public static void AddListnerAsync<P1, P2>(this GObject self, Func<EventContext, P1, P2, UniTask> action, P1 p1,
            P2 p2)
        {
            async UniTask ClickActionAsync(EventContext context)
            {
                FUICollectionService.Instance.isClicked = true;
                await action(context, p1, p2);
                FUICollectionService.Instance.isClicked = false;
            }

            self.onClick.Set((context) =>
            {
                if (FUICollectionService.Instance.isClicked)
                {
                    return;
                }

                UniTask.Void(async () => { await ClickActionAsync(context); });
            });
        }

        public static void AddListnerAsync<P1, P2, P3>(this GObject self,
            Func<EventContext, P1, P2, P3, UniTask> action, P1 p1, P2 p2, P3 p3)
        {
            async UniTask ClickActionAsync(EventContext context)
            {
                FUICollectionService.Instance.isClicked = true;
                await action(context, p1, p2, p3);
                FUICollectionService.Instance.isClicked = false;
            }

            self.onClick.Set((context) =>
            {
                if (FUICollectionService.Instance.isClicked)
                {
                    return;
                }

                UniTask.Void(async () => { await ClickActionAsync(context); });
            });
        }

        #endregion

        #region AddListner(this GObject self, Action<EventContext> action)

        public static void AddListner(this GObject self, Action<EventContext> action)
        {
            self.onClick.Set((contex) => { action?.Invoke(contex); });
        }

        public static void AddListner<P1>(this GObject self, Action<EventContext, P1> action, P1 p1)
        {
            self.onClick.Set((contex) => { action?.Invoke(contex, p1); });
        }

        public static void AddListner<P1, P2>(this GObject self, Action<EventContext, P1, P2> action, P1 p1, P2 p2)
        {
            self.onClick.Set((contex) => { action?.Invoke(contex, p1, p2); });
        }

        public static void AddListner<P1, P2, P3>(this GObject self, Action<EventContext, P1, P2, P3> action, P1 p1,
            P2 p2, P3 p3)
        {
            self.onClick.Set((contex) => { action?.Invoke(contex, p1, p2, p3); });
        }

        #endregion
    }
}