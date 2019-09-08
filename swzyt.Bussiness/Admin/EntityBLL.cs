using swzyt.IService;
using swzyt.Model;
using swzyt.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace swzyt.Bussiness.Admin
{
    public class EntityBLL
    {
        private IEntity iService = new EntityService();

        public MessageModel<string> CreateEntity(string entityName, string contentRootPath)
        {
            string[] arr = contentRootPath.Split('\\');
            string baseFileProvider = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                baseFileProvider += arr[i];
                baseFileProvider += "\\";
            }
            string filePath = baseFileProvider + "swzyt.Entity";
            if (iService.CreateEntity(entityName, filePath))
                return new MessageModel<string> { Success = true, Msg = "生成成功" };
            else
                return new MessageModel<string> { Success = false, Msg = "生成失败" };
        }
    }
}
