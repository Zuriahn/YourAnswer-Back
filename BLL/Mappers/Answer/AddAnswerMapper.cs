using BLL.ViewModel.Answer;
using DAL.DTO.Answer;
using DAL.Functions.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers.Answer
{
  public class AddAnswerMapper
  {
    public async Task<int> AddAnswer(AddAnswerVM AddAnswerVM)
    {
      return await new AddAnswerCS().AddAnswerAsync(new AnswerDTO
      {
        Description = AddAnswerVM.description,
        UserId= AddAnswerVM.userid,
        QuestionId = AddAnswerVM.questionid
      });

    }
  }
}
