using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEngine.Rendering.TooYoung
{
    [Serializable]
    [SupportedOnRenderPipeline(typeof(TYRenderPipelineAsset))]
    [Categorization.CategoryInfo(Name = "R: Runtime Assets", Order = 1000), HideInInspector]
    class TYRenderPipelineRuntimeAssets : IRenderPipelineResources
    {
        public int version => 0;

        bool IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild => true;
    }
}